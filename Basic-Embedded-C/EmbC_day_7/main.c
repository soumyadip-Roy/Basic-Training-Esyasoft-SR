#include "hal/hal_gpio.h"
#include "config/pin_config.h"


int main(void) {
	hal_gpio_init();
	
	while (1) {
	hal_gpio_digital_write();
	}
}
