#include <stdio.h> // Standard input/output library (for printf)

int main(){
    char buttonInput;
    int counter = 0; 	// Initialize counter variable
    int max_blinks = 5; 	// Maximum number of blinks
    int ledState = 0;
    int threshold = 5;
    int thresholdCount = 0;
    printf(" Press the button to toggle LED: \n");
    while(buttonInput != '\n' && thresholdCount<threshold){
        printf("button\n");
        scanf("%c", &buttonInput);
        if(buttonInput == '\n'){
            ledState = ~ledState;
            if(ledState){
                printf("LED ON: counter: %d\n", counter);
                
            }

            else {
                printf("LED OFF: counter: %d\n", counter);
               
                counter++;
            }

            if(counter>=max_blinks){
                printf("Max Blinks Reached... Reseting\n");
                printf("Threshold reached %d times\n", thresholdCount+1);
                counter = 0;
                thresholdCount++;
            }

        }
        buttonInput = '1';
    }

    printf("The user has crossed the required threshold...Exiting program\n");

    return 0;

}
