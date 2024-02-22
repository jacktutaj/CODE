import { Component, OnInit } from '@angular/core';
import { Product } from '../product';
import { NgFor } from '@angular/common';
import { ProductService } from '../service/product.service';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [NgFor],
  templateUrl: './products.component.html',
  styleUrl: './products.component.scss',
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.getProducts();
    this.productService.refreshRequired.subscribe(() => {
      this.getProducts();
    });
  }

  getProducts() {
    this.productService.getProducts().subscribe((data) => {
      this.products = data;
      console.info(data)
    });
  }
}
