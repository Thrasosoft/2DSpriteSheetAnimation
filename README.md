# 2DSpriteSheetAnimation
Character Controller and Animator for 2d Character and Animation tutorial

If you Use the UnityAsset Package you will need down download the [MartialHero](https://assetstore.unity.com/packages/2d/characters/martial-hero-170422?aid=1101laq4R) Asset to get the spriteSheets

If you Are looking for how to create the attack animation Here are the steps.  
  1. You need to add a new parameter to your animator This Parameter should be either a Boolean or a Trigger, I prefer a Trigger for this becuase it automatically resets once it is used.
  2. Add new transitions to each other animation from your attack animation, there should be mutliple conditions for each transition such as isAttacking, isMoving=true for the transtion from running to attacking.
  3. Add Code in your character controller to detect if a A key is being pressed to trigger the attack.
  4. Add a new Attack Method in your character controller to set your new trigger/boolean parameter in your animator.
  5. If you choose a boolean parameter, You need to set your isAttacking parameter in your animator to false when the attack key is not being pressed. (Not needed if you used a Trigger.)
  
  You can use the CharacterAnimator and Character controller in this repo as reference to see if you got the same answer I got. Ultimately if your attack animation works the way you want, you got the right answer. Learning Game Development is about making the game YOU want to make. Not the one I guide you towards.
Let me know if you have any questions, I'd love to help.
-Thrasonic
