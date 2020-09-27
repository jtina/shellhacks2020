using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class GlobalVariables
{
    public static int level = 0;
    public static ArrayList states = new ArrayList(new string[] {
        "Go to quickly to start the story",
        "Go to Tina's to continue the story",

        "You have picked yes! Now head to Quickly again!",
        "You have picked no :( Story ends here...",

        "You picked yes! Go on a date to Riverwalk!",
        "You picked no :( Story ends here...",

        "You picked yes! That's lovely!",
        "You picked no :) We are moving too fast...",
        "You are at Riverwalk for another date after a few weeks",

        "You picked yes! That's lovely!",
        "You picked no :) Story ends here...",

        "You picked yes! Yay!",
        "You picked no :) Story ends here...",

        "You picked yes! Amazing! You both get each other a gift!",
        "You picked no :) He gets a wonderful gift and you feel bad for not getting anything...",

        "Let's go! You both make an awesome project and demo it to the judges!",
        "You pick no and he gets real real sad... cuz ShellHacks is amazing!",


    });


    /*
     * 0 -> "Go to quickly to start the story"
     * 1 -> "Go to Tina's to continue the story"
     * apologize?
     * 2 -> "You have picked yes! Now head to Quickly again!"
     * 3 -> "You have picked no :( Story ends here..."
     * he asks you out?
     * 4 -> "You picked yes! Go on a date to Riverwalk!"
     * 5 -> "You picked no :( Story ends here..."
     * first kiss?
     * 6 -> "You picked yes! That's lovely!"
     * 7 -> "You picked no :) We are moving too fast..."
     * 8 -> "You are at Riverwalk for another date after a few weeks"
     * first kiss?
     * 9 -> "You picked yes! That's lovely!"
     * 10 -> "You picked no :) Story ends here..."
     * wanna be a gf?
     * 11 -> "You picked yes! Yay!"
     * 12 -> "You picked no :) Story ends here..."
     * 6-month anniversary is approaching. Get him a gift?
     * 13 -> "You picked yes! Amazing! You both get each other a gift!"
     * 14 -> "You picked no :) He gets a wonderful gift and you feel bad for not getting anything..."
     * Asks you to go to a hackathon!
     * 15 -> "Let's go! You both make an awesome project and demo it to the judges!"
     * 16 -> "You pick no and he gets real real sad... cuz ShellHacks is amazing!"
     */


    public static bool choice = false;
    public static int stage = 0;
    
}

/*
     * 0 -> "Go to quickly to start the story"
     * 1 -> "Go to Tina's to continue the story"
     * apologize?
     * 2 -> "You have picked yes! Now head to Quickly again!"
     * 3 -> "You have picked no 🙁 Story ends here..."
     * he asks you out?
     * 4 -> "You picked yes! Go on a date to Riverwalk!"
     * 5 -> "You picked no 🙁 Story ends here..."
     * first kiss?
     * 6 -> "You picked yes! That's lovely!"
     * 7 -> "You picked no 🙂 We are moving too fast..."
     * 8 -> "You are at Riverwalk for another date after a few weeks"
     * first kiss?
     * 9 -> "You picked yes! That's lovely!"
     * 10 -> "You picked no 🙂 Story ends here..."
     * wanna be a gf?
     * 11 -> "You picked yes! Yay!"
     * 12 -> "You picked no 🙂 Story ends here..."
     * 6-month anniversary is approaching. Get him a gift?
     * 13 -> "You picked yes! Amazing! You both get each other a gift!"
     * 14 -> "You picked no 🙂 He gets a wonderful gift and you feel bad for not getting anything..."
     * Asks you to go to a hackathon!
     * 15 -> "Let's go! You both make an awesome project and demo it to the judges!"
     * 16 -> "You pick no and he gets real real sad... cuz ShellHacks is amazing!"
     */
