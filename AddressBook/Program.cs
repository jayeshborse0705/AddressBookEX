﻿namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WelCome To The Address Book");
                Console.WriteLine("Select The Option For The Particular Address Book");
                Console.WriteLine("1 for the Friends.");
                Console.WriteLine("2 for the Office.");
                int option = Convert.ToInt32(Console.ReadLine());
                Program details = new Program();
                switch (option)
                {
                    case 1:
                        Friends friend = new Friends();
                        do
                        {
                            Console.WriteLine("\n1:To Add the Contacts");
                            Console.WriteLine("2:To View the contacts");
                            Console.WriteLine("3:To Edit the Contacts");
                            Console.WriteLine("4:To Remove a contact");
                            try
                            {
                                int option1 = Convert.ToInt32(Console.ReadLine());
                                switch (option1)
                                {
                                    case 1:
                                        friend.AddingContacts();
                                        continue;
                                    case 2:
                                        friend.DisplayContacts();
                                        break;
                                    case 3:
                                        friend.EditContact();
                                        break;
                                    case 4:
                                        friend.DeleteContact();
                                        break;
                                    case 0:
                                        Console.WriteLine("Exit");
                                        break;
                                    default:
                                        Console.WriteLine("Enter a valid Input");
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter a proper Value");
                            }
                        }
                        while (option != 0);
                        break;
                    case 2:
                        Office office = new Office();
                        do
                        {
                            Console.WriteLine("\n1:To Add the Contacts");
                            Console.WriteLine("2:To View the contacts");
                            Console.WriteLine("3:To Edit the Contacts");
                            Console.WriteLine("4:To Remove a contact");
                            try
                            {
                                int option1 = Convert.ToInt32(Console.ReadLine());
                                switch (option1)
                                {
                                    case 1:
                                        office.AddingContacts();
                                        continue;
                                    case 2:
                                        office.DisplayContacts();
                                        break;
                                    case 3:
                                        office.EditContact();
                                        break;
                                    case 4:
                                        office.DeleteContact();
                                        break;
                                    default:
                                        Console.WriteLine("Enter a valid Input");
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Enter a proper Value");
                            }
                        }
                        while (option != 0);
                        break;
                }
            }
        }

    }

}

