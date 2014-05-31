(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
MaltParser for .NET
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

<div class="row">
  <div class="span1"></div>
  <div class="span6">
    <div class="well well-small" id="nuget">
      The MaltParser for .NET library can be <a href="https://www.nuget.org/packages/MaltParser/">installed from NuGet</a>:
      <pre>PM> Install-Package MaltParser</pre>
    </div>
  </div>
  <div class="span1"></div>
</div>

*)
