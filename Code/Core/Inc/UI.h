/*
 * UI.h
 *
 *  Created on: May 4, 2024
 *      Author: Bence
 */

#ifndef INC_UI_H_
#define INC_UI_H_
#include "stm32f4xx_hal.h"

typedef enum{
	UP = 1,
	DOWN = 0
}Orientation;

int _write(int fd, char * ptr, int len);
void Start_buzzer();
void Stop_buzzer();
int32_t Calculate_bitmask(uint8_t value, Orientation display);

#endif /* INC_UI_H_ */
