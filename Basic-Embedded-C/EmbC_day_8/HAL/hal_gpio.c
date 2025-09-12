#include "hal_gpio.h"
#include "..\config\pin_config.h"


static int prevButtonState = 0;
static int buttonPressCount = 0;
void hal_gpio_init(){
    *led_ddr = 0xff;
    *button_ddr = 0x00;
    *button_port &= ~(1<<button_pin);
}


int hal_gpio_button_read(){
    return ((*button_port & (1<<button_pin)) ? 1 : 0);
}

int button_debounce(){
    int val = hal_gpio_button_read();
    _delay_ms(20); 
    int val_check = hal_gpio_button_read();
    if ((val == val_check) && (val == 1)) return 1;
    else return 0;
}

void hal_gpio_handle_button_press_and_blink(){
    int currentButtonState = button_debounce();
    if (currentButtonState && !prevButtonState) {
        buttonPressCount++;
        if (buttonPressCount > 3) buttonPressCount = 1;
    }
    prevButtonState = currentButtonState;

    hal_gpio_blink_led(buttonPressCount);
}

void hal_gpio_blink_led(int mode) {
    switch(mode) {
        case 1: 
            *led_port |= (1<<led_pin);
            _delay_ms(700);
            if(button_debounce()) break;
            else {
            *led_port &= ~(1<<led_pin);
            _delay_ms(700);
            break;
            }
        case 2: 
            *led_port |= (1<<led_pin);
            _delay_ms(150);
            if(button_debounce()) break;
            else {
            *led_port &= ~(1<<led_pin);
            _delay_ms(150);
            break;
            }
        case 3: 
            *led_port |= (1<<led_pin);
            break;
        default:
            break;
    }
}
