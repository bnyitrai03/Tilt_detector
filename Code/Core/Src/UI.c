/*
 * UI.c
 *
 *  Created on: May 4, 2024
 *      Author: Bence
 */
#include "UI.h"

extern TIM_HandleTypeDef htim10; // timer responsible for generating the buzzer signal

void Start_buzzer();
void Stop_buzzer();
void Display_limit(int16_t limit, Orientation facing);
void Display_tilt(int16_t tilt, Orientation facing);

void Start_buzzer(){
	HAL_TIM_Base_Start_IT(&htim10);
}

void Stop_buzzer(){
	HAL_TIM_Base_Stop_IT(&htim10);
}

void Display_limit(int16_t limit, Orientation facing){

}

void Display_tilt(int16_t tilt, Orientation facing){

}
