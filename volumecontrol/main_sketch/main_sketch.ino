#include <EtherCard.h>

uint16_t in;
int enable = 6;
int logic1 = 7;
int logic2 = 8;

static byte myip[]  = { 192,168,0,5 };
static byte gwip[]  = { 192,168,0,1 };
static byte mymac[] = { 0x74,0x69,0x69,0x2D,0x30,0x31 };
byte Ethernet::buffer[500];

char* statusLabel;
char* buttonLabel;

//TIJDELIJK
String inputstring = "";


void setup(){
  pinMode(enable,OUTPUT);
  pinMode(logic1,OUTPUT);
  pinMode(logic2,OUTPUT);
  
  Serial.begin(57600);
  Serial.println("\n[Volumecontrol gestart]");
  
  if (ether.begin(sizeof Ethernet::buffer, mymac,9) == 0) 
    Serial.println( "Fout bij opzetten netwerkverbinding");
    
  ether.staticSetup(myip, gwip);
  ether.printIp("IP:  ", ether.myip); 
}

void loop() { 
  word len = ether.packetReceive();
  word pos = ether.packetLoop(len);
  
  if(pos) {    
    if(strstr((char *)Ethernet::buffer + pos, "GET /?status=zachter") != 0
    || inputstring.indexOf('-') != 0
    ) {
      Serial.println("zachter...");
      zachter(20);
    }

    if(strstr((char *)Ethernet::buffer + pos, "GET /?status=harder") != 0) {
      Serial.println("HARDER");
      harder(20);
    }
    
    if(strstr((char *)Ethernet::buffer + pos, "GET /?status=nogzachter") != 0) {
      Serial.println("nog zachter...");
      zachter(50);
    }

    if(strstr((char *)Ethernet::buffer + pos, "GET /?status=nogharder") != 0) {
      Serial.println("NOG HARDER");
      harder(50);
    }
    
    BufferFiller bfill = ether.tcpOffset();
    bfill.emit_p(PSTR("HTTP/1.0 200 OK\r\n"), statusLabel, buttonLabel, buttonLabel);
    ether.httpServerReply(bfill.position());
  }
  
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputstring += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:    
  }
}


void zachter(int level){
  level = round(level*0.8);
  digitalWrite(logic1,LOW);
  digitalWrite(logic2,HIGH);
  digitalWrite(enable,HIGH);
  delay(level);
  digitalWrite(enable,LOW);
}

void harder(int level){
  digitalWrite(logic2,LOW);
  digitalWrite(logic1,HIGH);
  digitalWrite(enable,HIGH);
  delay(level);
  digitalWrite(enable,LOW);
}


