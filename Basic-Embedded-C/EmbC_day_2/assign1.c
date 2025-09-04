#include <stdio.h> // Standard input/output library (for printf)

// Assuming a microcontroller environment where GPIO is configured for LED
// For a real embedded system, these would be register accesses
#define LED_PIN 5 	// Example LED pin number

// Function to simulate a delay (blocking delay)
void delay_ms(int ms) {
    volatile long i, j; 
    j=0;
    for(i=0;i<ms;i++){
        j++;
    }	// Use volatile to prevent optimization
    
	
// Adjust this value for desired delay
               // Do nothing, just waste time
   
   
}

int main() {
    int counter = 0; 	// Initialize counter variable
    int max_blinks = 5; 	// Maximum number of blinks
    int threshold = 3; 	// Threshold for conditional check

    // Loop to blink the LED
    // The for loop iterates a known number of times (max_blinks)
    for (counter=0; counter<max_blinks;counter++){
    
        // Conditional statement (if-else)
        if (counter < threshold){
        // Checks if the current counter value is less than the threshold
        
            // Simulate turning LED ON (e.g., set pin high)
            printf("LED ON (Counter: %d)\n", counter);
            delay_ms(200); 	// For simulation
             			// Delay for 200 milliseconds

            // Simulate turning LED OFF (e.g., set pin low)
            printf("LED OFF (Counter: %d)\n", counter); 
            delay_ms(200);	// For simulation
             		// Delay for 200 milliseconds
        }
        //else 
        else{
            // If the counter is at or above the threshold
            printf("Counter reached threshold or above: %d\n", counter);
            delay_ms(500);

            		 // Longer delay
        }
        // Increment operator (++) used in the for loop condition
        // counter++ is equivalent to counter = counter + 1;
    
    }
    // Another conditional statement demonstrating logical operator
    
    if(counter< max_blinks && counter >= threshold){
       // Logical AND operator (&&)
        printf("Blinking sequence completed.\n");
    }

    // Example of a while loop
    int countdown = 3;
    //while loop for countdown
    while(countdown){
        printf("Countdown: %d\n", countdown);
         		// Decrement operator (--)
        countdown--;
        delay_ms(1000);
         //delay timer
    }
    printf("Liftoff!\n");

    return 0; 	// Indicate successful execution
} 