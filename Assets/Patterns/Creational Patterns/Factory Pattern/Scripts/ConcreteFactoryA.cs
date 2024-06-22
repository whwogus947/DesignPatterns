using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern
{
    public class ConcreteFactoryA : SkillFactory
    {
        public ProductA product;

        public override IProduct GetProduct(Vector3 position)
        {
            var clone = Instantiate(product);
            clone.Execute();
            clone.transform.position = Vector3.zero;
            clone.transform.localScale = Vector3.one * 1.5f;
            clone.GetComponent<Animator>().Play("Run");
            return clone;
        }

        public GameObject CreateSword()
        {
            var clone = Instantiate(product.gameObject);
            clone.transform.position = Vector3.zero;
            clone.transform.localScale = Vector3.one * 1.5f;
            clone.GetComponent<Material>().color = Color.white;
            return clone;
        }

        public enum WeaponType
        {
            None,
            Sword,
            Bow,
            Hammer,
        }

        public void Create(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Sword:
                    // Sword 생성
                    break;
                case WeaponType.Bow:
                    // Bow 생성
                    break;
                case WeaponType.Hammer:
                    // Hammer 생성
                    break;
            }
        }
    }
}
