#include <avr/io.h>
#include <util/delay.h>

#define LCDPIND7 PD7
#define LCDPIND6 PB0
#define LCDPIND5 PB1
#define LCDPIND4 PB2

#define LCDPINE PB3
#define LCDPINRS PB4

void lcd_pulse(){
    PORTB |= (1<<LCDPINE);
    _delay_us(1);
    PORTB &= ~(1<<LCDPINE);
    _delay_ms(2);
}

void lcd_command(unsigned char cmd){

    PORTB &= ~(1<<LCDPINRS);

    if(cmd & 0x10)PORTB |= (1<<LCDPIND4);else PORTB &= ~(1<<LCDPIND4);
    if(cmd & 0x20)PORTB |= (1<<LCDPIND5);else PORTB &= ~(1<<LCDPIND5);
    if(cmd & 0x40)PORTB |= (1<<LCDPIND6);else PORTB &= ~(1<<LCDPIND6);
    if(cmd & 0x80)PORTD |= (1<<LCDPIND7);else PORTD &= ~(1<<LCDPIND7);
    lcd_pulse();

    if(cmd & 0x01)PORTB |= (1<<LCDPIND4);else PORTB &= ~(1<<LCDPIND4);
    if(cmd & 0x02)PORTB |= (1<<LCDPIND5);else PORTB &= ~(1<<LCDPIND5);
    if(cmd & 0x04)PORTB |= (1<<LCDPIND6);else PORTB &= ~(1<<LCDPIND6);
    if(cmd & 0x08)PORTD |= (1<<LCDPIND7);else PORTD &= ~(1<<LCDPIND7);
    lcd_pulse();

}

void lcd_data(unsigned char data){
    PORTB |= (1<<LCDPINRS);

    if(data & 0x10)PORTB |= (1<<LCDPIND4);else PORTB &= ~(1<<LCDPIND4);
    if(data & 0x20)PORTB |= (1<<LCDPIND5);else PORTB &= ~(1<<LCDPIND5);
    if(data & 0x40)PORTB |= (1<<LCDPIND6);else PORTB &= ~(1<<LCDPIND6);
    if(data & 0x80)PORTD |= (1<<LCDPIND7);else PORTD &= ~(1<<LCDPIND7);
    lcd_pulse();

    if(data & 0x01)PORTB |= (1<<LCDPIND4);else PORTB &= ~(1<<LCDPIND4);
    if(data & 0x02)PORTB |= (1<<LCDPIND5);else PORTB &= ~(1<<LCDPIND5);
    if(data & 0x04)PORTB |= (1<<LCDPIND6);else PORTB &= ~(1<<LCDPIND6);
    if(data & 0x08)PORTD |= (1<<LCDPIND7);else PORTD &= ~(1<<LCDPIND7);
    lcd_pulse();
}
void lcd_init(){
    
    _delay_ms(20);
    lcd_command(0x02);
    lcd_command(0x28);
    lcd_command(0x0F);      
    lcd_command(0x06);
    lcd_command(0x01);
    _delay_ms(2);

}
void lcd_print(char *str){
    while(*str){lcd_data(*str++);}
}
int main (){

    DDRD |= (1<<LCDPIND7);
    DDRB |= (1<<LCDPIND6)|(1<<LCDPIND5)|(1<<LCDPIND4)|(1<<LCDPINE)|(1<<LCDPINRS);
    lcd_init();

    lcd_command(0x80);
    lcd_print("Hello World!");

    lcd_command(0xC0);
    lcd_print("-By XVCTR");

    while(1){
    }
    return 0;

}
