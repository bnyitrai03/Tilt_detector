/*
 * UI.c
 *
 *  Created on: May 4, 2024
 *      Author: Bence
 */
#include "UI.h"
#include "stm32f4xx_hal.h"

extern TIM_HandleTypeDef htim10; // timer responsible for generating the buzzer signal

void Start_buzzer();
void Stop_buzzer();
void Display_limit(uint16_t);
void Display_degree(uint16_t);

void Start_buzzer(){
	HAL_TIM_Base_Start_IT(&htim10);
}

void Stop_buzzer(){
	HAL_TIM_Base_Stop_IT(&htim10);
}

void Display_limit(uint16_t){

}

void Display_degree(uint16_t){

}
