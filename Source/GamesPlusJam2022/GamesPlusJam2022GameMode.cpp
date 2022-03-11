// Copyright Epic Games, Inc. All Rights Reserved.

#include "GamesPlusJam2022GameMode.h"
#include "GamesPlusJam2022Character.h"

AGamesPlusJam2022GameMode::AGamesPlusJam2022GameMode()
{
	// Set default pawn class to our character
	DefaultPawnClass = AGamesPlusJam2022Character::StaticClass();	
}
