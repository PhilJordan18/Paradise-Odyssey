// Fill out your copyright notice in the Description page of Project Settings.


#include "ParadiseAbilitySystemComponent.h"

#include "Characters/ParadiseCharacterBase.h"


// Sets default values for this component's properties
UParadiseAbilitySystemComponent::UParadiseAbilitySystemComponent()
{
	// Set this component to be initialized when the game starts, and to be ticked every frame.  You can turn these features
	// off to improve performance if you don't need them.
	PrimaryComponentTick.bCanEverTick = true;

	// ...
}


// Called when the game starts
void UParadiseAbilitySystemComponent::BeginPlay()
{
	Super::BeginPlay();

	// ...
	
}

void UParadiseAbilitySystemComponent::OnRep_ActivateAbilities()
{
	Super::OnRep_ActivateAbilities();

	bool AbilityChanged = false;
	AParadiseCharacterBase *CharacterBase = Cast<AParadiseCharacterBase>(GetOwner());
	
	if (!CharacterBase) return;

	if (LastActivableAbilities.Num() != ActivatableAbilities.Items.Num())
	{
		AbilityChanged = true;
	} else
	{
		for (int32 i = 0; i < LastActivableAbilities.Num(); i++)
		{
			if (LastActivableAbilities[i].Ability != ActivatableAbilities.Items[i].Ability)
			{
				AbilityChanged = true;
				break;
			}
		}
	}

	if (AbilityChanged)
	{
		CharacterBase->SendAbilitiesChangedEvent();
		LastActivableAbilities = ActivatableAbilities.Items; 
	}
}


// Called every frame
void UParadiseAbilitySystemComponent::TickComponent(float DeltaTime, ELevelTick TickType,
                                                    FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);

	// ...
}

