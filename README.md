# MinRotatingDice


This algorithm finds minimum count of rotating in given list of dice numbers to make same surface. 

Basically the sum of the opposite surface is 7. The rotation of the opposite surface is 2 times. The rotation of other adjacent surfaces is only once. 

# Conclusion

When opposite side is found, it is multiplied by 2 and sum other adjacent dice number count. This gives you rotation times to target surface. 
It is calculated for 6 surfaces and found all count of rotation to all surfaces. Minimum count of rotation gives to you dice number to make same surface for given all list(It keeps in a dictionary for all dice surfaces)
