#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN_OFF PD2
#define LED_PIN_ON PD5
#define LED_PIN_TOG PD7


int main(){
    DDRD |= (1<<LED_PIN_ON);
    DDRD |= (1<<LED_PIN_OFF);
    DDRD |= (1<<LED_PIN_TOG);
    
    PORTD |= (1<<LED_PIN_OFF);
    PORTD &= ~(1<<LED_PIN_ON);

    _delay_ms(1000);

    PORTD |= (1<<LED_PIN_ON);

    if(PORTD & (1<<LED_PIN_OFF)){
    PORTD ^= (1<<LED_PIN_OFF);
    }
    while(1){
        PORTD ^= (1<<LED_PIN_TOG);
        _delay_ms(1000); 
    }
    

}