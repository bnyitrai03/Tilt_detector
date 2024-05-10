/*
 * UI.c
 *
 *  Created on: May 4, 2024
 *      Author: Bence
 */
#include "UI.h"
#include <stdio.h>

extern TIM_HandleTypeDef htim10; // timer responsible for generating the buzzer signal
extern UART_HandleTypeDef huart2;

int _write(int fd, char * ptr, int len);
void Start_buzzer();
void Stop_buzzer();
int32_t Calculate_bitmask(uint8_t value, Orientation display);
static int32_t Convert_digit_UPSIDE(uint8_t digit);
static int32_t Convert_digit_DOWNSIDE(uint8_t digit);

// Redirect the printf to COM port
int _write(int fd, char * ptr, int len)
{
  HAL_UART_Transmit(&huart2, (uint8_t *) ptr, len, HAL_MAX_DELAY);
  return len;
}

void Start_buzzer(){
	HAL_TIM_Base_Start_IT(&htim10);
}

void Stop_buzzer(){
	HAL_TIM_Base_Stop_IT(&htim10);
}

int32_t Calculate_bitmask(uint8_t digit, Orientation display){
	int32_t bitmask;

	switch(display){
	case UP:
		bitmask = Convert_digit_UPSIDE(digit);
		break;
	case DOWN:
		bitmask = Convert_digit_DOWNSIDE(digit);
		break;
	default:
		bitmask = 0;
	}

	return bitmask;
}

/*
The FYS-3911BUHR-21 segments:
     __A__
    B     F
    |__G__|
    E     C
    |__D__|

the wires are connected like:
	bit0 -> A
	bit1 -> B
	bit2 -> C
	bit3 -> D

	bit4 -> E
	bit5 -> F
	bit6 -> G

the numbers will look like:
 _         _    _         _    _    _    _    _
| |   |    _|   _|  |_|  |_   |_     |  |_|  |_|
|_|   |   |_    _|    |   _|  |_|    |  |_|   _|
0x3F 0x24 0x79 0x6D 0x66 0x4F 0x5F 0x25 0x7F 0x6F

 */
static int32_t Convert_digit_UPSIDE(uint8_t digit){
	int32_t bitmask;
	switch(digit){
	case 0:
		bitmask = 0x3F;
		break;
	case 1:
		bitmask = 0x24;
		break;
	case 2:
		bitmask = 0x79;
		break;
	case 3:
		bitmask = 0x6D;
		break;
	case 4:
		bitmask = 0x66;
		break;
	case 5:
		bitmask = 0x4F;
		break;
	case 6:
		bitmask = 0x5F;
		break;
	case 7:
		bitmask = 0x25;
		break;
	case 8:
		bitmask = 0x7F;
		break;
	case 9:
		bitmask = 0x6F;
		break;
	default:
		// If the input digit is not between '0' and '9', return 0
		bitmask = 0;
		break;
	}

	return bitmask;
}

/*
The FYS-3911BUHR-21 segments:
     __A__
    B     F
    |__G__|
    E     C
    |__D__|

the wires are connected like:
	bit0 -> A
	bit1 -> B
	bit2 -> C
	bit3 -> D

	bit4 -> E
	bit5 -> F
	bit6 -> G

the upside down numbers will look like:
 _         _    _         _    _         _    _
| |   |    _|  |_   |_   |_   |_|  |    |_|  |_
|_|   |   |_   |_   | |   _|   _|  |_   |_|  |_|
0x3F 0x12 0x79 0x5B 0x56 0x4F 0x6F 0x1A 0x7F 0x5F

 */
static int32_t Convert_digit_DOWNSIDE(uint8_t digit){
    int32_t bitmask;
    switch (digit) {
        case 0:
            bitmask = 0x3F;
            break;
        case 1:
            bitmask = 0x12;
            break;
        case 2:
            bitmask = 0x79;
            break;
        case 3:
            bitmask = 0x5B;
            break;
        case 4:
            bitmask = 0x56;
            break;
        case 5:
            bitmask = 0x4F;
            break;
        case 6:
            bitmask = 0x6F;
            break;
        case 7:
            bitmask = 0x1A;
            break;
        case 8:
            bitmask = 0x7F;
            break;
        case 9:
            bitmask = 0x5F;
            break;
        default:
            // If the input digit is not between '0' and '9', return 0
            bitmask = 0;
            break;
    }
    return bitmask;
}

