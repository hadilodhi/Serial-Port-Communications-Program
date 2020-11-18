#include <SoftwareSerial.h>

//SoftwareSerial mySerial(7, 8); // RX, TX
int led = 13; // the pin the LED is connected to

void setup() {
  pinMode(led, OUTPUT); // Declare the LED as an output
//  Serial.begin(1200);
//  while (!Serial) {
//    ; // wait for serial port to connect. Needed for Native USB only
//  }
//  mySerial.begin(1200);
}

void loop() {
  digitalWrite(led, HIGH); // Turn the LED on
  delay(1);
  digitalWrite(led, LOW); // Turn the LED on
  delay(1);
//  if (mySerial.available())
//    Serial.write(Serial.read());
//  if (Serial.available())
//    mySerial.write(Serial.read());
}
