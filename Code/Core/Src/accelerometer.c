/*
 * Accelerometer.c
 *
 *  Created on: May 4, 2024
 *      Author: Bence
 */
#include "main.h"
#include "lsm6dsl.h"
#include "stm32f4xx_nucleo_bus.h"

void MEMS_Init();
int32_t wrap_platform_read(uint8_t Address, uint8_t Reg, uint8_t *Bufp, uint16_t len);
int32_t wrap_platform_write(uint8_t Address, uint8_t Reg, uint8_t *Bufp, uint16_t len);
int Measure_degree();
static int Calculate_degree();

LSM6DSL_Object_t Accelometer;
LSM6DSL_Axes_t acc_axes;
static int16_t i = 0;

int32_t wrap_platform_read(uint8_t Address, uint8_t Reg, uint8_t *Bufp, uint16_t len){
  uint32_t ret;
  Reg |= 0x80;
  ret = BSP_SPI2_Send(&Reg, 1);
  ret = BSP_SPI2_Recv(Bufp, len);
  return ret;
}

int32_t wrap_platform_write(uint8_t Address, uint8_t Reg, uint8_t *Bufp, uint16_t len){
  uint32_t ret;
  ret = BSP_SPI2_Send(&Reg, 1);
  ret = BSP_SPI2_Send(Bufp, len);
  return ret;
}

void MEMS_Init()
{
  LSM6DSL_IO_t io_ctx;
  uint8_t id;
  LSM6DSL_AxesRaw_t axes;

  /* Link SPI functions to the LSM6DSL driver */
  io_ctx.BusType   = LSM6DSL_SPI_4WIRES_BUS;
  io_ctx.Address   = 0;
  io_ctx.Init    = BSP_SPI2_Init;
  io_ctx.DeInit   = BSP_SPI2_DeInit;
  io_ctx.ReadReg   = wrap_platform_read;
  io_ctx.WriteReg  = wrap_platform_write;
  io_ctx.GetTick   = BSP_GetTick;
  LSM6DSL_RegisterBusIO(&Accelometer, &io_ctx);

  /* Read the LSM6DSL WHO_AM_I register */
  uint8_t ret = LSM6DSL_ReadID(&Accelometer, &id);
  if (id != LSM6DSL_ID) {
    Error_Handler();
  }

  /* Initialize the LSM6DSL sensor */
  LSM6DSL_Init(&Accelometer);

  /* Configure the LSM6DSL accelerometer (ODR, scale and interrupt) */
  LSM6DSL_ACC_SetOutputDataRate(&Accelometer, 26.0f); /* 26 Hz */
  LSM6DSL_ACC_SetFullScale(&Accelometer, 4);          /* [-4000mg; +4000mg] */
  //LSM6DSL_ACC_Set_INT1_DRDY(&Accelometer, ENABLE);    /* Enable DRDY */
  LSM6DSL_ACC_GetAxesRaw(&Accelometer, &axes);        /* Clear DRDY */

  /* Start the LSM6DSL accelerometer */
  LSM6DSL_ACC_Enable(&Accelometer);
}

int Measure_degree(){
	if(i == 90){
		i = -91;
	}
	i++;
	return i;
}
