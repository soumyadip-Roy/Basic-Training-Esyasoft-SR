#include <avr/io.h>
#include <util/delay.h>

#define led_port &PORTB
#define led_ddr &DDRB


void main(){
    while(1){
        DDRB |= (1<<5);
        PORTB |=(1<<5);
    }
}