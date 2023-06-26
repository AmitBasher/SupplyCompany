global using AutoMapper;
global using MediatR;

global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;

global using SupplyCompany.Api.Common;
global using SupplyCompany.Api.Common.IMapper;

global using SupplyCompany.Application;
global using SupplyCompany.Application.Interfaces.Repositories;
global using SupplyCompany.Application.Users.Common;
global using SupplyCompany.Application.Users.Commands.Register;
global using SupplyCompany.Application.Users.Queries.Login;
global using SupplyCompany.Application.Products.Commands.Create;
global using SupplyCompany.Application.Suppliers.Commands.Create;
global using SupplyCompany.Application.Customers.Commands.Create;
global using SupplyCompany.Application.ProductReviews.Commands.Create;
global using SupplyCompany.Application.SupplierReviews.Commands.Create;
global using SupplyCompany.Application.SupplyRequests.Commands.Create;
global using SupplyCompany.Application.Orders.Commands.Create;
global using SupplyCompany.Application.Common.Command;

global using SupplyCompany.Domain.Models.product;
global using SupplyCompany.Domain.Models.supplier;
global using SupplyCompany.Domain.Models.customer;
global using SupplyCompany.Domain.Models.supplierReview;
global using SupplyCompany.Domain.Models.supplyRequest;
global using SupplyCompany.Domain.Models.order;
global using SupplyCompany.Domain.Models.productReview;

global using SupplyCompany.DTO.Authentication;
global using SupplyCompany.DTO.Product;
global using SupplyCompany.DTO.ProductReview;
global using SupplyCompany.DTO.Supplier;
global using SupplyCompany.DTO.Customer;
global using SupplyCompany.DTO.SupplierReview;
global using SupplyCompany.DTO.SupplyRequest;
global using SupplyCompany.DTO.Order;
global using SupplyCompany.DTO.Common;