/*
 * Accelerometer.h
 *
 *  Created on: May 4, 2024
 *      Author: Bence
 */

#ifndef INC_ACCELEROMETER_H_
#define INC_ACCELEROMETER_H_

void MEMS_Init();
int32_t wrap_platform_read(uint8_t Address, uint8_t Reg, uint8_t *Bufp, uint16_t len);
int32_t wrap_platform_write(uint8_t Address, uint8_t Reg, uint8_t *Bufp, uint16_t len);

#endif /* INC_ACCELEROMETER_H_ */
