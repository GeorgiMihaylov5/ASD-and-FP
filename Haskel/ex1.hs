addMe :: Integer -> Integer -> Integer
addMe x y = x + y

main :: IO ()
main =  do
    putStr "Sum of x + y = "
    print(addMe 10 25)
    print(addMe 15 12)
    print(addMe 2 3)