
using MiniProjectGuestBook;

string name = GuestBookMethod.Welcome();

int numberOfGuest = GuestBookMethod.NumberOfGuest(name);

List<string> guestList = GuestBookMethod.ListofGuest(numberOfGuest);

GuestBookMethod.ConfirmGuestList(name, guestList);