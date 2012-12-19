
8 constant xsize
8 constant ysize

: world-size xsize ysize * ;

: array-index ( address x y -- element-address )
  ysize mod swap
  xsize mod swap
  xsize * + cells + ;

: array-index! array-index ! ;
: array-index@ array-index @ ;

: dump-world ( world -- )
  world-size 0 do
    dup i cells + @ .
    i 1+ xsize mod 0= if cr then
  loop ;

variable world 
  world-size cells allot
world world-size cells erase

1 world 2 2 array-index!
1 world 3 2 array-index!
1 world 4 2 array-index!
1 world 4 3 array-index!
1 world 3 4 array-index!

world dump-world

