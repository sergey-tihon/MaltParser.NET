(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"
#I "../../src/temp/ikvm-7.4.5196.0/bin/"

(**
Parse sentences with MaltParser
===============================================

This example shows how to parse a sentence with MaltParser by first initialize a parser model.

To run this example requires that you have created `swemalt-1.7.2i.mco`. 

You can download model from [pre-trainted models page](http://www.maltparser.org/mco/mco.html).

*)
#r "maltparser-1.8.dll"
#r "IKVM.OpenJDK.Core.dll"

open java.io
open java.net

open org.maltparser.concurrent
open org.maltparser.concurrent.graph

// Loading the Swedish model swemalt-1.7.2
let swemaltMiniModelURL = File(__SOURCE_DIRECTORY__ + "/../../bin/swemalt-1.7.2.mco").toURI().toURL()
let model = ConcurrentMaltParserService.initializeParserModel(swemaltMiniModelURL)

// Creates an array of tokens, which contains the Swedish sentence 
// 'Samtidigt får du högsta sparränta plus en skattefri sparpremie.'
// in the CoNLL data format.
let tokens = 
  [|"1\tSamtidigt\t_\tAB\tAB\t_"
    "2\tfår\t_\tVB\tVB\tPRS|AKT"
    "3\tdu\t_\tPN\tPN\tUTR|SIN|DEF|SUB"
    "4\thögsta\t_\tJJ\tJJ\tSUV|UTR/NEU|SIN/PLU|DEF|NOM"
    "5\tsparränta\t_\tNN\tNN\tUTR|SIN|IND|NOM"
    "6\tplus\t_\tAB\tAB\t_"
    "7\ten\t_\tDT\tDT\tUTR|SIN|IND"
    "8\tskattefri\t_\tJJ\tJJ\tPOS|UTR|SIN|IND|NOM"
    "9\tsparpremie\t_\tNN\tNN\tUTR|SIN|IND|NOM"
    "10\t.\t_\tMAD\tMAD\t_"|]

let outputGraph = model.parse(tokens)
printfn "%A" outputGraph

// [fsi:1	Samtidigt	_	AB	AB	_	2	TA	_	_]
// [fsi:2	får	_	VB	VB	PRS|AKT	0	ROOT	_	_]
// [fsi:3	du	_	PN	PN	UTR|SIN|DEF|SUB	2	SS	_	_]
// [fsi:4	högsta	_	JJ	JJ	SUV|UTR/NEU|SIN/PLU|DEF|NOM	5	AT	_	_]
// [fsi:5	sparränta	_	NN	NN	UTR|SIN|IND|NOM	2	OO	_	_]
// [fsi:6	plus	_	AB	AB	_	5	ET	_	_]
// [fsi:7	en	_	DT	DT	UTR|SIN|IND	9	DT	_	_]
// [fsi:8	skattefri	_	JJ	JJ	POS|UTR|SIN|IND|NOM	9	AT	_	_]
// [fsi:9	sparpremie	_	NN	NN	UTR|SIN|IND|NOM	6	PA	_	_]
// [fsi:10	.	_	MAD	MAD	_	2	IP	_	_]