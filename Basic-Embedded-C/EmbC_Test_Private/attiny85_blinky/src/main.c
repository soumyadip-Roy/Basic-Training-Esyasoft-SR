#include <avr/io.h>
#include <util/delay.h>

#define led_port 
#define led_ddr &DDRB


void main(){
    DDRB |= (1<<5);
    PORTB &=~(1<<5);
    while(1){
        PORTB ^=(1<<5);
        _delay_ms(200);
        
    }
}