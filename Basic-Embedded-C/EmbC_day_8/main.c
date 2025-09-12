// #include "config/pin_config.h"


// 	hal_gpio_init();
// 	static int buttonPressCount = 0;
	
// 	while (1) {
// 	buttonPressCount = hal_gpio_digital_write(buttonPressCount);

// 	}
#include "hal/hal_gpio.h"
#include "config/pin_config.h"

int main(void) {
	hal_gpio_init();
	while (1) {
		hal_gpio_handle_button_press_and_blink();
	}
}