#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN PINB5
#define BUTTON_PIN PD4

int main(void){

    DDRB |= (1<<LED_PIN);
    DDRD &= ~(1<<BUTTON_PIN);

    while(1){
        if((PIND & (1<<BUTTON_PIN))){
        PORTB |= (1<<LED_PIN);
        _delay_ms(1000);

        PORTB &= (0<<LED_PIN);
        _delay_ms(1000);
        }
        else{
            PORTB &= (0<<LED_PIN);
        }

    }
    return 0;
}
