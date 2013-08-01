package Patterns::Creational::Abstract_Factory::Minnestrone;

use Moo;
extends 'Patterns::Creational::Abstract_Factory::Soup';

sub BUILDARGS
{
   {
      soupName => "Minnestrone",
      soupIngredients => [
        "1 Pound tomatos",
        "1/2 cup pasta",
        "1 cup tomato juice",
      ]
    }
}

1;
