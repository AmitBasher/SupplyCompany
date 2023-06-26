global using SupplyCompany.Domain.Models.user;
global using SupplyCompany.Domain.Models.supplier;
global using SupplyCompany.Domain.Models.customer;
global using SupplyCompany.Domain.Models.product;
global using SupplyCompany.Domain.Models.product.Entity.subProduct;
global using SupplyCompany.Domain.Models.supplyRequest;
global using SupplyCompany.Domain.Models.supplierReview;
global using SupplyCompany.Domain.Models.productReview;
global using SupplyCompany.Domain.Models.order;
global using SupplyCompany.Domain.Models.Common;

global using Microsoft.Extensions.DependencyInjection;
global using MediatR;
global using SupplyCompany.Application.Users.Common;
global using SupplyCompany.Application.Common.Interfaces.Authentication;
global using SupplyCompany.Application.Interfaces.Repositories;

global using SupplyCompany.Infrastructure.DAL.Repository;
global using SupplyCompany.Application.Common.Command;