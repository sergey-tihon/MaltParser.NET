[![Build status](https://ci.appveyor.com/api/projects/status/jq3h7fa35es41v67?svg=true)](https://ci.appveyor.com/project/sergey-tihon/maltparser-net)

MaltParser for .NET [![NuGet Status](http://img.shields.io/nuget/v/MaltParser.svg?style=flat)](https://www.nuget.org/packages/MaltParser/)
===================

[MaltParser](http://www.maltparser.org/) is a system for data-driven dependency parsing, which can be used to induce a parsing model from treebank 
data and to parse new data using an induced model. `MaltParser` is developed by `Johan Hall`, `Jens Nilsson` and `Joakim Nivre` 
at Växjö University and Uppsala University, Sweden.


`MaltParser` implements nine deterministic parsing algorithms:

*   Nivre arc-eager
*   Nivre arc-standard
*   Covington non-projective
*   Covington projective
*   Stack projective
*   Stack swap-eager
*   Stack swap-lazy
*   Planar (implemented by `Carlos Gómez-Rodríguez`)
*   2-planar (implemented by `Carlos Gómez-Rodríguez`)

`MaltParser` allows users to define feature models of arbitrary complexity.

`MaltParser` currently includes two machine learning packages (thanks to `Sofia Cassel` for her work on LIBLINEAR):

*   `LIBSVM` - A Library for Support Vector Machines (Chang, 2001).
*   `LIBLINEAR` -- A Library for Large Linear Classification (Fan et al., 2008).

`MaltParser` can also be turned into a phrase structure parser that recovers both continuous and discontinuous phrases 
with both phrase labels and grammatical functions (Hall and Nivre, 2008a; Hall and Nivre, 2008b).
