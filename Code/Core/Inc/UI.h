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

void Start_buzzer();
void Stop_buzzer();
void Display_tilt(int16_t tilt, Orientation facing);
void Display_limit(int16_t limit, Orientation facing);

#endif /* INC_UI_H_ */
