# ggj-2021-lost-and-found
 
deck of magical cards is falling in super slow motion.
you're a little dude trying to collect them all into a sorted deck before they hit the ground.

giant trash chute / incinerator. small platforms jutting out of walls
cards are platforms
floor is lava

you can run, jump, climb on platforms - standard, fairly agile 3d character controller
you have a small number of hit points.
you can collect cards into the deck in the following way:
    if you're near a card and it's the next in the deck, you can press a button to place it on top of the deck (the physical card object is removed)
    if you're near a card and it's not the next in the deck, you can press a button to collect it and carry it around as long as you have a free inventory slot. you have 3-5 inventory slots.
    if you have a card in an inventory slot and it's the next in the deck, it will be automatically added to the deck, freeing up the slot.

cards have a front face and a back face. 
back face is just a normal platform.
front face has an ability which triggers when you collide with it.
clubs punch you in the direction normal to the front face. They also do 1 damage.
hearts heal you for 1 health.
others undecided

maybe just face cards have these abilities?
maybe abilities recharged when the player stands on a different platform?
maybe abilities can only be used once per card? 
maybe diamonds recharge abilities of neighboring cards?

a level for each interesting deck sorting order
    -numbers, then suits
    -suits, then numbers
    -random

add other falling objects for flavor? joker card maybe?