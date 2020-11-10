using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MvvmHelpers;

namespace LosGatos.Models
{
    /// <summary>
    /// Simple model for hosting sample content and storing app state
    /// </summary>
    public class AppModel : BaseViewModel
    {
        private ObservableCollection<Gatos> cart = new ObservableCollection<Gatos>();
        private Gatos selectedGatos;

        public AppModel()
        {
        }

        public List<Gatos> Gatos { get; set; } = new List<Gatos>()
        {
            new Gatos{
                Name = "Cute Kitten Girl",
                Tag = "Furry Art Illustration",
                Description = "Scamper attack the dog then pretend like nothing happened. Hack up furballs i'm bored inside, let me out i'm lonely outside, let me in i can't make up my mind whether to go in or out, guess i'll just stand partway in and partway out.",
                Price = "$22.95",
                ProductImage = "shutterstock_553119223.png",
                Stars = "3.5"
            },
            new Gatos{
                Name = "Black Cat",
                Tag = "City Style",
                Description = "Drink water out of the faucet cat cat moo moo lick ears lick paws or cats are fats i like to pets them they like to meow back. Scratch at door to be let outside, get let out then scratch at door immmediately after to be let back in i could pee on this if i had the energy.",
                Price = "$32.95",
                ProductImage = "shutterstock_208551202.png",
                Stars = "3"
            },
            new Gatos{
                Name = "Hipster Cat",
                Tag = "Fashion Illustration",
                Description = "Fat baby cat best buddy little guy cry louder at reflection. Cat snacks pee in human's bed until he cleans the litter box so get scared by doggo also cucumerro and allways wanting food.",
                Price = "$12.95",
                ProductImage = "shutterstock_188816654.png",
                Stars = "4"
            },
            new Gatos{
                Name = "Cranky Cat",
                Tag = "No!",
                Description = "Stare at ceiling poop in litter box, scratch the walls destroy house in 5 seconds for curl up and sleep on the freshly laundered towels murder hooman toes present belly, scratch hand when stroked. Munch, munch, chomp, chomp.",
                Price = "$12.95",
                ProductImage = "shutterstock_183490616.png",
                Stars = "5"
            },
            new Gatos{
                Name = "The Lion",
                Tag = "Hakuna Matata",
                Description = "Chew iPad power cord. Give me some of your food give me some of your food give me some of your food meh, i don't want it funny little cat chirrup noise shaking upright tail when standing next to you for purrr purr littel cat, little cat purr purr.",
                Price = "$12.95",
                ProductImage = "shutterstock_183490631.png",
                Stars = "4"
            },
            new Gatos{
                Name = "Urban Cat",
                Tag = "Anthropomorphic",
                Description = "Meeeeouw cats are fats i like to pets them they like to meow back meow and walk away. Grab pompom in mouth and put in water dish scoot butt on the rug but mesmerizing birds, hiss at vacuum cleaner.",
                Price = "$12.95",
                ProductImage = "shutterstock_186919337.png",
                Stars = "4"
            }
        };

        public ObservableCollection<Gatos> Cart
        {
            get { return cart; }
            set
            {
                SetProperty(ref cart, value);
            }
        }
        public ObservableCollection<Gatos> Favorites { get; set; } = new ObservableCollection<Gatos>();

        public ObservableCollection<Gatos> SaveForLater { get; set; } = new ObservableCollection<Gatos>();

        public Gatos SelectedGatos
        {
            get => selectedGatos;
            set
            {
                SetProperty(ref selectedGatos, value);
            }
        }

        public void AddToCartByName(string catName)
        {
            var g = Gatos.Where(x => x.Name == catName).Single();
            Cart.Add(
                g
            );
        }
    }
}
