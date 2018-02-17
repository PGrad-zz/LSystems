using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class LSystem : MonoBehaviour {
	public List<Rule> rules;
	public string sentence = "F";

	public void Awake() {
	}

	public void Generate() {
		StringBuilder nextAxiom = new StringBuilder();
		string production;
		foreach(char c in sentence) {
			production = c.ToString();
			foreach(Rule rule in rules)
				if(rule.LHS == c) {
					production = rule.RHS;
					break;
				}
			nextAxiom.Append(production);
		}
		sentence = nextAxiom.ToString();
	}
}
