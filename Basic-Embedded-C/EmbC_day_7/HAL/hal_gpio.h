
#ifndef HAL_GPIO_H
#define HAL_GPIO_H

#include <avr/io.h>
#include <util/delay.h>

void hal_gpio_init();
int hal_gpio_button_read();
int button_debounce();
void hal_gpio_handle_button_press_and_blink();
void hal_gpio_blink_led(int count);

#endif
