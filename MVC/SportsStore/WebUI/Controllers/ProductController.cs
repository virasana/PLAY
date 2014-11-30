﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Ninject;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        public int PageSize = 3;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult List(string category, int page = 1)
        {
            var model = new ProductsListViewModel
            {
                Products = _repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfoViewModel = new PagingInfoViewModel()
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = _repository.Products.Count(),
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}