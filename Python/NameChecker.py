def MallieFunction(name):
    if name == 'MallieMommyMilkies':
        print("That's correct")
    else:
        print("LMAO no its not\n")
        name = input('Your name is:\n')
        MallieFunction(name)
name = input('Your name is:\n')
MallieFunction(name)