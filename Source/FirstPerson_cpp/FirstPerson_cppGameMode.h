// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "FirstPerson_cppGameMode.generated.h"

/**
 *  Simple GameMode for a first person game
 */
UCLASS(abstract)
class AFirstPerson_cppGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	AFirstPerson_cppGameMode();
};



